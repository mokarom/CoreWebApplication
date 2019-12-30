using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApplication.Models
{
    public class IndexViewModel
    {
        public string CampaignName { get; set; }
        public string ListName { get; set; }

        public int SelectedTemplate { get; set; }
        public SelectList Templates()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            List<string> temaplteNames = new List<string>();

            foreach (var temaplteName in temaplteNames)
            {
                items.Add(new SelectListItem
                {
                    Value = "True",
                    Text = temaplteName,
                });
            }

            return new SelectList(items, "Value", "Text");
        }
        public static IndexViewModel CreateModel()
        {
            return new IndexViewModel();
        }
    }
}
