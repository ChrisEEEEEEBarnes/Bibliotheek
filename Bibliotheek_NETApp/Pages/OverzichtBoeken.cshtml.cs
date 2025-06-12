using Domain_Bibliotheek.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bibliotheek_NETApp.Pages
{
    public class OverzichtBoekenModel : PageModel
    {
        public List<Boeken> Boekenlijst { get; set; }
        //String die het huidige sorteercriterium bijhoudt
        public string CurrentSort {  get; set; }

        //Filtereigenschappen waarmee gebruikers kunnen filteren
        [BindProperty(SupportsGet = true)]
        public string TitelFilter {  get; set; }

        [BindProperty(SupportsGet = true)]
        public string GenreFilter { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? MinBladzijden{ get; set; }

        [BindProperty(SupportsGet = true)]
        public int? MaxBladzijden { get; set; }
        public void OnGet(string sortOrder)
        {
            Domain_Bibliotheek.Business.Controller controller = new Domain_Bibliotheek.Business.Controller();
            Boekenlijst = controller.GetBoeken;

            CurrentSort = sortOrder;
            //COntroller wordt aangemaakt om films op te halen
            controller = new Domain_Bibliotheek.Business.Controller();
            //Films worden opgehaald als een queryable lijst
            var boek = controller.GetBoeken.AsQueryable();

            //toepassen van filters
            //Als de TitelfFilter niet leeg is, filteren we de boeken op titel
            if (!string.IsNullOrEmpty(TitelFilter))
                boek = boek.Where(b => b.Titel.Contains(TitelFilter, StringComparison.OrdinalIgnoreCase));

            //Als de GenreFilter niet leeg is, filteren we de boeken op Genre
            if (!string.IsNullOrEmpty(GenreFilter))
                boek = boek.Where(b => b.Genre.Contains(GenreFilter, StringComparison.OrdinalIgnoreCase));

            //Als er een MinBladzijden is opgegeven, filteren we de boeken waarvan de MinBladzijden hoger is dan het gegeven getal
            if (MinBladzijden.HasValue)
                boek = boek.Where(b => b.Blz >= MinBladzijden.Value);

            //Als er een MaxBladzijden is opgegeven, filteren we de boeken waarvan de Maxbladzijden lager is dan het gegeven getal
            if (MaxBladzijden.HasValue)
                boek = boek.Where(b => b.Blz <= MaxBladzijden.Value);

            //Sorteren op basis van sortOrder
            //Afhankelijk van de waarde van sortOrder worden de boeken op verschillende manieren gesorteerd
            Boekenlijst = sortOrder switch
            {
                //sorteer op titel(oplopend)
                "Titel" => boek.OrderBy(b => b.Titel).ToList(),

                //sorteer op titel(aflopend)
                "titel_desc" => boek.OrderByDescending(b => b.Titel).ToList(),

                //sorteer op genre(oplopend)
                "genre" => boek.OrderBy(b => b.Genre).ToList(),

                //sorteer op genre(aflopend)
                "genre_desc" => boek.OrderByDescending(b => b.Genre).ToList(),

                //sorteer op Bladzijden(oplopend)
                "bladzijden" => boek.OrderBy(b => b.Blz).ToList(),

                //sorteer op Bladzijden(aflopend)
                "bladzijden_desc" => boek.OrderByDescending(b => b.Blz).ToList(),

                //sorteer op Bladzijden(oplopend)
                "graad" => boek.OrderBy(b => b.Graad).ToList(),

                //sorteer op Bladzijden(aflopend)
                "graad_desc" => boek.OrderByDescending(b => b.Graad).ToList(),

                //Als er geen specifieke sorteeroptie is, retourneer dan de films in de oorspronkelijke volgorde
                _ => boek.ToList(),
            };
        }
    }
}
