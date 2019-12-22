/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package ModelClass;

/**
 *
 * @author ind
 */
public class BusBean {
    String no;
    String From;
    String To;
    String Type;

    public void setType(String Type) {
        this.Type = Type;
    }

    public void setTo(String To) {
        this.To = To;
    }

    public void setNo(String no) {
        this.no = no;
    }

    public void setFrom(String From) {
        this.From = From;
    }

    public String getType() {
        return Type;
    }

    public String getTo() {
        return To;
    }

    public String getNo() {
        return no;
    }

    public String getFrom() {
        return From;
    }


}
