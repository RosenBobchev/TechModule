import java.util.Scanner;

public class P9MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String line = scan.nextLine();
        String[] arr = line.split("\\s+");
        int[] arr2 = new int[arr.length];
        for (int i = 0; i < arr.length; i++) {
            arr2[i] = Integer.parseInt(arr[i]);
        }
        int counter = 0;
        int number=0;
        int maxCount = 0;
        int mostFrequent = arr2[0];
        for (int i = 0; i < arr2.length-1; i++) {
            number=arr2[i];
            for (int j = 0; j < arr.length; j++) {
                if (arr2[i] == arr2[j]){
                    counter++;
                }
            }
            if (counter > maxCount){
                maxCount=counter;
                mostFrequent = number;
            }
            counter = 0;
        }
        System.out.println(mostFrequent);
    }
}

