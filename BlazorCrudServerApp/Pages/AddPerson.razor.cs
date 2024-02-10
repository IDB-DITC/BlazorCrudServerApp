using BlazorCrudServerApp.Models;

namespace BlazorCrudServerApp.Pages
{
    public partial class AddPerson
    {

       
         Person person = new ();



        void SavePerson()
        {

            db.People.Add(person);
            db.SaveChanges();

            navManager.NavigateTo("/ppl");
        }
    }
}