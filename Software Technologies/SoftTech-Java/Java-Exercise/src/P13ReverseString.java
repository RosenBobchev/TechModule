import java.util.Scanner;

public class P13ReverseString {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String line = scan.nextLine();
        String reversed = new StringBuilder(line).reverse().toString();
        System.out.println(reversed);
    }
}
