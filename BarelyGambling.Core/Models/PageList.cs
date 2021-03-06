using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarelyGambling.Core.Models
{
    public class PageList<T>:List<T>
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get;private set; }
        public bool HasPrevious => (CurrentPage > 1);
        public bool HasNext => (CurrentPage < TotalPages);
        public PageList(List<T> items,int count,int pageNumber,int pageSize)
        {
            TotalCount = count;
            PageSize = pageSize;
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            AddRange(items);
        }
        public static async Task<PageList<T>> Create(IQueryable<T> source,int pageNumber,int pageSize) {
            var count =await source.CountAsync();
            var items =await source.Skip(pageSize * (pageNumber - 1))
                .Take(pageSize).ToListAsync();

            return new PageList<T>(items,count,pageNumber,pageSize);
        }
    }
}
