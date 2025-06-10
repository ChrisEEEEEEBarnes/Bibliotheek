using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Bibliotheek_NETApp.Pages
{
    public class AddBoekenRazorModel : PageModel
    {
        [BindProperty]
        public string Titel { get; set; }
        [BindProperty]
        public string ISBN { get; set; }
        [BindProperty]
        public int Graad { get; set; }
        [BindProperty]
        public int Blz { get; set; }
        [BindProperty]
        public int GenreID { get; set; }

        public string Bericht { get; set; }
        public void OnGet()
        {
            //leeg - we geven niets weer
        }
        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                //als de gegevens ongeldig zijn
                //herlaad de pagina zonder iets op te slaan
                return Page();
            }
            //Controller aanmaken
            Domain_Bibliotheek.Business.Controller controller = new Domain_Bibliotheek.Business.Controller();
            //Metghode oproepen
            controller.AddBoek(Titel, ISBN, Graad, Blz, GenreID);
            //Toon bevestigningsbericht
            Bericht = "Boek toegevoegd";
            //wis de invoervelden op het formulier zodat het opnieuw leeg is
            ModelState.Clear();
            //Herlaad pagina
            return Page();
        }
    }
}
