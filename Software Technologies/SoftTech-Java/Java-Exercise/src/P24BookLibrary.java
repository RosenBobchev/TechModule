import java.text.*;
import java.util.*;

class Books {
    private String title;
    private String name;
    private double price;
    private Date releaseDate;


    public Books(String title, String name, double price, Date releaseDate) {
        this.name = name;
        this.title = title;
        this.price = price;
        this.releaseDate = releaseDate;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getTitle() {
        return title;
    }

    public void getTitle(String title) {
        this.title = title;
    }

    public double getPrice() {
        return price;
    }

    public void getPrice(double price) {
        this.price = price;
    }

    public Date getReleaseDate() {
        return releaseDate;
    }

    public void getReleaseDate(Date releaseDate) {
        this.releaseDate = releaseDate;
    }
}

class Library {
    private String name;
    private double priceSum;

    public Library(String name, double priceSum) {
        this.name = name;
        this.priceSum = priceSum;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getPriceSum() {
        return priceSum;
    }

    public void setPriceSum(double priceSum) {
        this.priceSum = priceSum;
    }

}

public class P24BookLibrary {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int bookNumber = scan.nextInt();
        scan.nextLine();
        Books[] result = new Books[bookNumber];
        DateFormat df = new SimpleDateFormat("dd.MM.yyyy");
        for (int i = 0; i < bookNumber; i++) {
            String[] inputBooks = scan.nextLine().split(" ");
            String name = inputBooks[1];
            String title = inputBooks[0];
            double price = Double.parseDouble(inputBooks[5]);
            String date = inputBooks[3];
            Date date1 = null;
            try {
                date1 = df.parse(date);
            } catch (ParseException e) {
                e.printStackTrace();
            }
            Books student = new Books(title, name, price,date1);
            result[i]=student;
        }
        List<Library> output = new ArrayList<>();
        for (int i = 0; i < result.length; i++) {
            String name = result[i].getName();
            double price = result[i].getPrice();
            Library lib = new Library(name,price);
            boolean flag = false;
            for (Library li : output) {
                if (li.getName().equalsIgnoreCase(name)){
                    double oldPrice= li.getPriceSum();
                    oldPrice+=price;
                    li.setPriceSum(oldPrice);
                    flag=true;
                }
            }
            if (!flag){
                output.add(lib);
            }
        }

        Collections.sort(output, new ObjectComparator());

        for (Library entry : output) {
            DecimalFormat decf = new DecimalFormat("#.00");
            System.out.println(MessageFormat.format("{0} -> {1}", entry.getName(), decf.format(entry.getPriceSum())));
        }
    }

}
class ObjectComparator implements Comparator{

    public int compare(Object obj1, Object obj2) {
        double x3 = ((Library) obj1).getPriceSum();
        double x4 = ((Library) obj2).getPriceSum();
        int sComp = Double.compare(x4,x3);
        if (sComp != 0) {
            return sComp;
        } else {
            String x1 = ((Library) obj1).getName();
            String x2 = ((Library) obj2).getName();
            return  x1.compareTo(x2);
        }
    }
}