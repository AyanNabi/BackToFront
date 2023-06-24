using FrontToBack.Models;
using System.Collections.Generic;

namespace FrontToBack.ViewModels
{
    public class PaginationVM<T>
    {

        public List<T> Items { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public PaginationVM(List<T> items, int currentpage, int pagecount)
        {
            Items = items;
            CurrentPage = currentpage;
            PageCount = pagecount;  


        }
    }
}
