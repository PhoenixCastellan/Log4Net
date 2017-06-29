using log4net;

public class LogHelper
{
    private static readonly LogHelper instance = new LogHelper();
    private static ILog apiLog = null;
    private static ILog dbLog = null;

    private LogHelper()
    {
        // XmlConfigurator.Configure();    
        LogLog.InternalDebugging = true;


    }
    public static ILog ApiLog()
    {
        if (apiLog == null)
        {
            apiLog = LogManager.GetLogger("ApiLog");
        }
        return apiLog;

    }
    public static ILog DbLog()
    {
        if (dbLog == null)
        {
            dbLog = LogManager.GetLogger("ApiLog");
        }
        return dbLog;

    }
}