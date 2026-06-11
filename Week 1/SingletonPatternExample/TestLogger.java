public class TestLogger {

    public static void main(String[] args) {

        System.out.println("===== Singleton Pattern Demo =====\n");

        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();

        logger1.log("Application Started");
        logger2.log("User Logged In");

        System.out.println();

        if (logger1 == logger2) {
            System.out.println(" Only one Logger instance exists.");
        } else {
            System.out.println("Multiple Logger instances exist.");
        }

        System.out.println("\nProgram Executed Successfully.");
    }
}