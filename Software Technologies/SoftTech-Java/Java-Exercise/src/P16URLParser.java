import java.text.MessageFormat;
import java.util.Scanner;

public class P16URLParser {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        String protocol = "";
        String resource = "";
        String server = "";
        if (input.contains("://")) {
            String[] splited = input.split("://");
            protocol = splited[0];
            String rest = splited[1];
            if (rest.contains("/")){
                String[] protocolSplited = rest.split("/");
                server = protocolSplited[0];
                resource = rest.substring(server.length()+1);
            }
            else {
                server = rest;
            }
            System.out.println(MessageFormat.format("[protocol] = \"{0}\"",protocol));
            System.out.println(MessageFormat.format("[server] = \"{0}\"",server));
            System.out.println(MessageFormat.format("[resource] = \"{0}\"",resource));
        }
        else {
            if (input.contains("/")){
                String[] protocolSplited = input.split("/");
                server = protocolSplited[0];
                resource = input.substring(server.length()+1);
            }
            else {
                server = input;
            }
            System.out.println(MessageFormat.format("[protocol] = \"{0}\"",protocol));
            System.out.println(MessageFormat.format("[server] = \"{0}\"",server));
            System.out.println(MessageFormat.format("[resource] = \"{0}\"",resource));
        }
    }
}
