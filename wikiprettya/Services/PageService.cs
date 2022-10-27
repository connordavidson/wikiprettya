using System; 
using System.Collections.Generic;
using wikiprettya.Models;
using System.Linq; 
using Microsoft.EntityFrameworkCore; 

namespace wikiprettya.Services;

public interface IPageService : IService<Page> 
{ 
    public int ReturnOne() ; 
}

public class PageService : IPageService 
{ 

    private dbContext _context ; 

    public PageService( dbContext context)
    {
        _context = context ; 
    }



    public int ReturnOne() 
    {
        return 1 ;
    }



    public async Task<Page> GetById(uint id) 
    { 
        var page = await _context.Pages.Where(p => p.PageId == id).FirstOrDefaultAsync() ; 
        return page ; 
    }

    public async Task<ICollection<Page>> GetAll() 
    { 
        var pages = await _context.Pages.ToListAsync(); 
        return pages; 
    }




}