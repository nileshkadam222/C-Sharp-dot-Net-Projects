/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package ModelClass;

import java.util.Date;

/**
 *
 * @author ind
 */
public class LogBean {
    String Name;
    String User;
    String Pass;
    String EmailID;
    int Tag;
    String City;

    public int getTag() {
        return Tag;
    }

    public void setTag(int Tag) {
        this.Tag = Tag;
    }

  

    public String getCity() {
        return City;
    }

  

    public void setCity(String City) {
        this.City = City;
    }

    public void setUser(String User) {
        this.User = User;
    }

    public void setPass(String Pass) {
        this.Pass = Pass;
    }

    public void setName(String Name) {
        this.Name = Name;
    }

    public void setEmailID(String EmailID) {
        this.EmailID = EmailID;
    }

   

    public String getUser() {
        return User;
    }

    public String getPass() {
        return Pass;
    }

    public String getName() {
        return Name;
    }

    public String getEmailID() {
        return EmailID;
    }

  
}
