using Cat2;
using System.Net.Http.Headers;

public static class Program
{
    public static void Main()
    {
        Doctor ophtalmologist = new Ophthalmologist("Иванов И.А",36,5,06);
        ophtalmologist.Display();

        Doctor neurologist = new Neurologist("Митина К.Л",52,17,15);
        neurologist.Display();

        Doctor cardiologist = new Cardiologist("Симонов Л.Л", 45, 9, 04);
        cardiologist.Display();

        var patient1 = new Patient("Морин В.П", 65, 895976481,"ИБС", "good");
        patient1.CurePatient(patient1);
        patient1.Display();

        var patient2 = new Patient("Кокорин В.Р", 34, 892934578, "Миопия", "bad");
        patient2.CurePatient(patient2);
        patient2.Display();

        var patient3 = new Patient("Антоненко В.Д",47, 89364778, "Невралгия", "good");
        patient3.CurePatient(patient3);
        patient3.Display();



        
       
    }
}
