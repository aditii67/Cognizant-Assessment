public class Logger {

    // Single instance of Logger
    private static Logger instance = new Logger();

    // Private constructor
    private Logger() {
        System.out.println("Logger initialized successfully.");
    }

    // Global access point
    public static Logger getInstance() {
        return instance;
    }

    // Logging method
    public void log(String message) {
        System.out.println("[LOG] " + message);
    }
}