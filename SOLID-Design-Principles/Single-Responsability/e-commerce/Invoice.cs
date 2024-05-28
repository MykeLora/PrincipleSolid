public class Invoices
{
    private readonly ILogger logger;
    private readonly MailSender mailSender;

    public long InvAmount{ get; set; }
    public DateTime InvDate{ get; set;}

     public Invoices(ILogger logger, MailSender mailSender)
    {
        this.logger = logger;
        this.mailSender = mailSender;
    }

    public void AddInvoice()
    {
        try
        {
            logger.Info("Add method Start");

            mailSender.EMailFrom = "MykeLora@gmail.com";
            mailSender.EMailTo = "franklinloragarcia@gmail.com";
            mailSender.EMailSubject = "Hola como estas?";
            mailSender.EMailBody = "Estaba programando cuando te envié este mensaje";
            mailSender.SendEmail();
        }
        catch (Exception ex)
        {
            
            logger.Error("Error Ocurred while Generating Invoice", ex);
        }
    }

    public void DeleteInvoice()
    {
        try
        {
            logger.Info("Delete Invoice Start at @"+ DateTime.Now);
        }
        catch (Exception ex)
        {
            logger.Error("Error Occurred while Deleting Invoice", ex);
            
        }
    }

}
