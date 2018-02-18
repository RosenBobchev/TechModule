import jdk.nashorn.internal.ir.IfNode;

import java.util.Scanner;

public class P4VowelOrDigit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String word = scan.nextLine();

        if (word .equals("1") || word.equals("0") || word.equals("2") || word.equals("3") || word.equals("4") || word.equals("5") || word.equals("6")|| word.equals("7")|| word.equals("8") || word.equals("9")){
            System.out.println("digit");
        }else if (word .equals("a") || word.equals("e") || word.equals("o") || word.equals("y") || word.equals("i") || word.equals("u")){
            System.out.println("vowel");
        }else{
            System.out.println("other");
        }
    }
}
