using System;
public class Program
{

    public static void Main(string[] args)
    {
        
        AdminUser adminUser = new AdminUser();
        adminUser.CreateDocument("Text Document");
        adminUser.ReadDocument(1);
        adminUser.UpdateDocument(1, "Updating the Content");
        adminUser.DeleteDocument(1);

        ReadOnlyUser readOnlyUser = new ReadOnlyUser();
        readOnlyUser.ReadDocument(1);

        Console.ReadKey();
    }

}