using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class InquietudesController : Controller
{
    private readonly ApplicationDbContext _context;

    public InquietudesController(ApplicationDbContext context){
        
         _context = context;
    }

    [HttpGet]

    public IActionResult Crear(){
        return View();
    }

     [HttpPost]

     public async Task<IActionResult> Crear(InquietudesContacto inquietudescontacto)
     {
        if(ModelState.IsValid){
            _context.Add(inquietudescontacto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(inquietudescontacto);
     }

    public async Task<IActionResult> Index(InquietudesContacto inquietudescontacto){

        return View(await _context.InquietudesContacto.ToArrayAsync());
    }
}