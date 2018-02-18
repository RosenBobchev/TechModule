import java.util.Arrays;
import java.util.Scanner;

public class P7MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] numbers = Arrays.stream(scan.nextLine()
                .split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int count = 0;
        int currentCount = 1;
        int number = 0;

        for (int i = 0; i < numbers.length - 1; i++) {
            if (numbers[i] == numbers[i + 1]){
                currentCount++;
                if (currentCount > count){
                    count = currentCount;
                    number = numbers[i];
                }
            }else{
                currentCount = 1;
            }
        }

        for (int i = 0; i < count; i++) {
            System.out.printf("%d ", number);
        }
    }
}
