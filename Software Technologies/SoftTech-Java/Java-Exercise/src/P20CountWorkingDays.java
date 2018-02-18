import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Scanner;

public class P20CountWorkingDays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String inputDate = scan.nextLine();
        String inputDate2 = scan.nextLine();
        DateFormat df = new SimpleDateFormat("dd-MM-yyyy");
        Date date1 = null;
        Date date2 = null;
        try {
            date1 = df.parse(inputDate);
            date2 = df.parse(inputDate2);
        } catch (ParseException e) {
            e.printStackTrace();
        }
        int result = getWorkingDaysBetweenTwoDates(date1,date2);
        System.out.println(result);
    }

    public static int getWorkingDaysBetweenTwoDates(Date startDate, Date endDate) {
        Calendar startCal = Calendar.getInstance();
        startCal.setTime(startDate);
        startCal.add(Calendar.DATE, -1);

        Calendar endCal = Calendar.getInstance();
        endCal.setTime(endDate);
        int workDays = 0;

        //Return 0 if start and end are the same
        if (startCal.getTimeInMillis() == endCal.getTimeInMillis()) {
            return 0;
        }

        if (startCal.getTimeInMillis() > endCal.getTimeInMillis()) {
            startCal.setTime(endDate);
            endCal.setTime(startDate);
        }
        String [] dates = {"Jan 01","Mar 03","May 01","May 06","May 24","Sep 06","Sep 22","Nov 01","Dec 24","Dec 25","Dec 26"};
        do {
            startCal.add(Calendar.DAY_OF_MONTH, 1);
            if (startCal.get(Calendar.DAY_OF_WEEK) != Calendar.SATURDAY && startCal.get(Calendar.DAY_OF_WEEK) != Calendar.SUNDAY) {
                Date date = startCal.getTime();
                String test = date. toString();
                String result = test.substring(4, 10);
                boolean flag = true;
                for (int i = 0; i < dates.length; i++) {
                    if (result.equalsIgnoreCase(dates[i])){
                        flag = false;
                    }
                }
                if (flag){
                    ++workDays;
                }
            }
        } while (startCal.getTimeInMillis() < endCal.getTimeInMillis());

        return workDays;
    }
}
