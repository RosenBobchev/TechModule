import java.util.Arrays;
import java.util.Scanner;

public class P6CompareCharArrays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] firstArr = scan.nextLine().split(" ");
        String[] secondArr = scan.nextLine().split(" ");

        String firstList = String.join("", firstArr);
        String secondList = String.join("", secondArr);

        String[] result = new String[2];

        result[0] = firstList;
        result[1] = secondList;

        Arrays.sort(result);

        for (int i = 0; i < result.length; i++) {
            System.out.println(result[i]);
        }
    }
}