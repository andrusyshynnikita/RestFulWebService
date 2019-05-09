using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross.Base;
using MvvmCross.Binding.Extensions;
using MvvmCross.Platforms.Ios.Binding.Views;
using RestFulWebService.Models;
using UIKit;
using WebService.IOS.Views.Cells;

namespace WebService.IOS.Sources
{
    public class CityTableViewSource : MvxTableViewSource
    {
        private Action _loadMore;
        public CityTableViewSource(UITableView uITableView, Action loadMore ) : base(uITableView)
        {
            _loadMore = loadMore;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var group = ItemsSource.ElementAt(indexPath.Row) as CityModel;

            var cell = GetOrCreateCellFor(tableView, indexPath, group);
            return cell;
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            var cell = tableView.DequeueReusableCell(CityViewCell.Key) as CityViewCell;

            if (cell == null)
            {
                cell = CityViewCell.Create();
            }

            var bindable = cell as IMvxDataConsumer;
            if (bindable != null)
                bindable.DataContext = item;
            return cell;
        }

        public override void WillDisplay(UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
        {
            if (indexPath.Row == ItemsSource.Count() - 1)
            {
                _loadMore.Invoke();
            }
        }
    }
}