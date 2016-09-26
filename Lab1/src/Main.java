import java.util.Scanner;

class Main {

    final static String FILENAME = "db.csv";

    public static void main(String[] args) {

        System.out.println("Enter username:");
        Scanner in = new Scanner(System.in);
        String name = in.nextLine();

        CSVReader csvReader = new CSVReader(FILENAME, name);
        csvReader.OutputIDs();
    }
}
