import java.text.MessageFormat;
import java.util.Scanner;
import java.util.TreeMap;

public class P19PhonebookUpgrade {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        TreeMap<String, String> map = new TreeMap<String, String>();
        while (true) {
            String input = scan.nextLine();
            if (input.contains("END")){
                break;
            }
            String[] splited = input.split(" ");
            String command = splited[0];
            switch (command){
                case "A":
                    if (map.containsKey(splited[1])){
                        map.replace(splited[1],splited[2]);
                    }
                    else {
                        map.put(splited[1],splited[2]);
                    }
                    break;
                case "S":
                    if (map.containsKey(splited[1])){
                        String value = map.get(splited[1]);
                        System.out.println(MessageFormat.format("{0} -> {1}",splited[1],value));
                    }
                    else {
                        System.out.println(MessageFormat.format("Contact {0} does not exist.",splited[1]));
                    }
                    break;
                case "ListAll":
                    for (String key : map.keySet()) {
                        System.out.println(MessageFormat.format("{0} -> {1}",key,map.get(key)));
                    }
                    break;
            }
        }
    }
}
