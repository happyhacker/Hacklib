using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace HackLib.UIHelpers {
  public class SelectListHelper {
    public IList<SelectListItem> GetMonthsList(int monthNum) {
      IList<SelectListItem> MonthsSelectList = new List<SelectListItem>();
      SelectListItem item;
      int count = 0;
      List<string> months = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList();
      item = new SelectListItem();
      item.Value = count.ToString();
      item.Text = "";
      MonthsSelectList.Add(item);

      foreach (string month in months) {
        count++;
        item = new SelectListItem();
        item.Value = count.ToString();
        item.Text = month;
        if (count == monthNum) {
          item.Selected = true;
        }
        MonthsSelectList.Add(item);
      }

      return MonthsSelectList;
    }


  }
}
