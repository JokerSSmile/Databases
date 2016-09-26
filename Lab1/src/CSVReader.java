import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.util.Vector;

public class CSVReader {

    private final String SEPARATOR = ",";
    private final int NAME_POSITION = 4;
    private final int ID_POSITION = 0;

    private Vector<String> IDs;

    public CSVReader(String filename, String name)
    {
        IDs = new Vector<>();

        FindIDsByName(filename, name);
    }

    private void FindIDsByName(String filename, String name)
    {
        String line = "";

        try (BufferedReader reader = new BufferedReader(new FileReader(filename))) {
            while ((line = reader.readLine()) != null)
            {
                String data[] = line.split(SEPARATOR);

                if (data[NAME_POSITION].replaceAll("\"", "").equals(name))
                {
                    IDs.add(data[ID_POSITION]);
                }
            }
        }
        catch (IOException err)
        {
            err.printStackTrace();
        }
    }

    public void OutputIDs()
    {
        System.out.println("Record id (Found " + IDs.size() + " matches):");

        for (int i = 0; i < IDs.size(); i++)
        {
            System.out.print(IDs.get(i));
            if (i != IDs.size() - 1)
            {
                System.out.print(", ");
            }
        }
    }

}
