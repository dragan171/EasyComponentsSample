using EasyComponentsSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace EasyComponentsSample.Pages
{
    public class EasyCheckBoxListModel : PageModel
    {
        public EasyCheckBoxListModel()
        {

        }

        [BindProperty]
        public TestModel testModels { get; set; } = new();


        public async Task OnGetAsync()
        {
            var list1 = new List<TestModel1>();
            list1.Add(new TestModel1 { Name_1 = "Marco", Value_1 = "1000", Info_1 = "i1", Checked_1 = false });
            list1.Add(new TestModel1 { Name_1 = "Peter", Value_1 = "2000", Info_1 = "i2", Checked_1 = false });
            list1.Add(new TestModel1 { Name_1 = "John", Value_1 = "3000", Info_1 = "i3", Checked_1 = false });
            list1.Add(new TestModel1 { Name_1 = "Stephen", Value_1 = "4000", Info_1 = "i4", Checked_1 = false });
            list1.Add(new TestModel1 { Name_1 = "Robert", Value_1 = "5000", Info_1 = "i5", Checked_1 = false });
            list1.Add(new TestModel1 { Name_1 = "Anton", Value_1 = "6000", Info_1 = "i6", Checked_1 = false });
            list1.Add(new TestModel1 { Name_1 = "Victor", Value_1 = "7000", Info_1 = "i7", Checked_1 = false });

            var list2 = new List<TestModel2>();
            list2.Add(new TestModel2 { Name_2 = "Ana", Value_2 = "1100", Info_2 = "i-1", Checked_2 = false });
            list2.Add(new TestModel2 { Name_2 = "Sophia", Value_2 = "2200", Info_2 = "i-2", Checked_2 = false });
            list2.Add(new TestModel2 { Name_2 = "Helena", Value_2 = "3300", Info_2 = "i-3", Checked_2 = false });
            list2.Add(new TestModel2 { Name_2 = "Emilia", Value_2 = "4400", Info_2 = "i-4", Checked_2 = false });
            list2.Add(new TestModel2 { Name_2 = "Ines", Value_2 = "2200", Info_2 = "i-2", Checked_2 = false });
            list2.Add(new TestModel2 { Name_2 = "Yvonne", Value_2 = "3300", Info_2 = "i-3", Checked_2 = false });
            list2.Add(new TestModel2 { Name_2 = "Sara", Value_2 = "4400", Info_2 = "i-4", Checked_2 = false });

            testModels.List1 = list1;
            testModels.List2 = list2;
        }

        public async Task OnPostAsync(string? action)
        {
            var actuel = testModels;
        }
    }
}
