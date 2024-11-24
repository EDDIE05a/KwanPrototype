using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


public class InquietudesController : Controller
{
    private readonly ApplicationDbContext _context;

    public InquietudesController(ApplicationDbContext context){
        
         _context = context;
    }

    [HttpGet]

    public IActionResult Contacto(){
        return View();
    }

    [HttpPost]

    public async Task<IActionResult> Contacto (InquietudesContacto inquietudescontacto)
    {
        if(ModelState.IsValid){
            _context.Add(inquietudescontacto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(inquietudescontacto);
    }


}