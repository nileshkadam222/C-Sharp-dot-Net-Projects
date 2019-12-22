/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package DB;
import Conn.GenUtility;
import ModelClass.LogBean;
import com.mysql.jdbc.PreparedStatement;
import com.mysql.jdbc.Statement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

/**
 *
 * @author ind
 */
public class VisitDB {
      Connection conn=null;
    PreparedStatement ps=null;
    ResultSet rs=null;
    Statement st=null;
    GenUtility gen=new GenUtility();
    String sql="";
    LogBean logbean=new LogBean();
     public LogBean getUserDetail(String user,String pass){
     sql="select name,emailid,tag,city from user_table where username='"+user+"' and password='"+pass+"'";
      try{
            conn=gen.dbconnection();
            ps=(PreparedStatement) conn.prepareStatement(sql);
            rs=ps.executeQuery();
            while(rs.next()){
            logbean.setName(rs.getString(1));
            logbean.setEmailID(rs.getString(2));
            logbean.setTag(rs.getInt(3));
            logbean.setCity(rs.getString(4));

            }

      }catch(Exception E){
          System.out.print(" at Verify moethod LogDB "+E);
      }
     return logbean;
 }
      public boolean  verify(String user,String pass){
      boolean flag=false;
      sql="select * from user_table where username='"+user+"' and password='"+pass+"'";
      try{
            conn=gen.dbconnection();
            ps=(PreparedStatement) conn.prepareStatement(sql);
            rs=ps.executeQuery();
            while(rs.next()){
                flag=true;
            }

      }catch(Exception E){
          System.out.print(" at Verify moethod LogDB "+E);
      }
     return flag;
  }
   public int Signup( LogBean logbean){
       conn=gen.dbconnection();
         boolean flag=false;
         int counter=0;
         String sql="";
       try{
        DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
       //get current date time with Date()
       Date date = new Date();
       String dt1=dateFormat.format(date);
    //   System.out.println(dt1);
       sql="select * from user_table where username='"+logbean.getUser()+"'";
       ps=(PreparedStatement) conn.prepareStatement(sql);
       rs=ps.executeQuery();
       while(rs.next()){
           counter=1;
       }
       if(counter==0){
        sql="insert into user_table (name,username,password,emailid,city,tag,dt) "
            +" values('"+logbean.getName()+"','"+logbean.getUser()+"','"+logbean.getPass()+"','"+logbean.getEmailID()+"','"+logbean.getCity()+"',3,'"+dt1+"')";
       System.out.println("sql "+sql);
       ps=(PreparedStatement) conn.prepareStatement(sql);
       ps.executeUpdate();

        /////-----check wheather entry is avialable ---

       sql="select * from user_table where name='"+logbean.getName()+"' and username='"+logbean.getUser()+"' and tag=3  and password='"+logbean.getPass()+"'";
       ps=(PreparedStatement) conn.prepareStatement(sql);
       rs=ps.executeQuery();
       while(rs.next()){
         counter=2;
       }


       }



     }catch(Exception E){
         System.out.println("Ezception signup "+E);
     }
       return counter;
  }
}
