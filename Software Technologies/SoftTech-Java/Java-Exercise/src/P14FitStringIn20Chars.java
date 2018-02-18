import java.util.Scanner;

public class P14FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String line = scan.nextLine();
        if (line.length() > 20){
            System.out.println(line.substring(0,20));
        }
        else {
            for (int i = line.length(); i <20 ; i++) {
                line = line+"*";
            }
            System.out.println(line);
        }
    }
}
