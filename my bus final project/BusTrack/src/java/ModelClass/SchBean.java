/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package ModelClass;

/**
 *
 * @author ind
 */
public class SchBean {
String busno;
String travel_time;
String scr_time;
String dest_time;
String eventTm;
float price;

    public String getTravel_time() {
        return travel_time;
    }

    public String getScr_time() {
        return scr_time;
    }

    public float getPrice() {
        return price;
    }

    public String getDest_time() {
        return dest_time;
    }

    public void setTravel_time(String travel_time) {
        this.travel_time = travel_time;
    }

    public void setScr_time(String scr_time) {
        this.scr_time = scr_time;
    }

    public void setPrice(float price) {
        this.price = price;
    }

    public void setDest_time(String dest_time) {
        this.dest_time = dest_time;
    }

   

    public String getEventTm() {
        return eventTm;
    }

  

    public String getBusno() {
        return busno;
    }

   
    public void setEventTm(String eventTm) {
        this.eventTm = eventTm;
    }

   
    public void setBusno(String busno) {
        this.busno = busno;
    }
}
