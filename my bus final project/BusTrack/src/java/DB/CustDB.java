/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package DB;

import Conn.GenUtility;
import ModelClass.CustBean;
import java.sql.*;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;
/**
 *
 * @author ind
 */
public class CustDB {
      Connection conn=null;
    PreparedStatement ps=null;
    ResultSet rs=null;
    Statement st=null;
    GenUtility gen=new GenUtility();
    String sql="";

        public void insertCustReserv(CustBean cust){
            sql="select max(id) from cust_reserv";
             int id=0;
            conn=gen.dbconnection();
            try{
            System.out.println("sql "+sql);
            DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
            Date date = new Date();
            String dt1=dateFormat.format(date);
               
                ps=conn.prepareStatement(sql);
                rs=ps.executeQuery();
                while(rs.next()){
                    id=rs.getInt(1);
                }
                id=id+1;
            sql="insert into cust_reserv(id,username,busno,travel_dt,seatno,custname,gender,age,mobileno,emailid,cardno,cadname,cww,price,active,dt)"
                    + " values("+id+",'"+cust.getUsername()+"','"+cust.getBusno()+"','"+cust.getTravelDt()+"','"+cust.getSeatNo()+"','"+cust.getCustname()+"','"+cust.getGender()+"','"+cust.getAge()+"','"+cust.getMob()+"','"+cust.getEmailid()+"','"+cust.getCardno()+"','"+cust.getCardname()+"','"+cust.getCWW()+"',"+cust.getPrice()+",'Y','"+dt1+"')";
            System.out.println("sql "+sql);
            ps=conn.prepareStatement(sql);
            ps.executeUpdate();
            System.out.println("Seact NO "+Integer.parseInt(cust.getSeatNo().trim()));
            ////update seat no

            sql="update bus_reserv set tag='0' where  seatno="+Integer.parseInt(cust.getSeatNo().trim())+"  and busno='"+cust.getBusno()+"' and travel_dt='"+cust.getTravelDt()+"'";
            System.out.println("sql "+sql);
            ps=conn.prepareStatement(sql);
            ps.executeUpdate();

            }catch(Exception E){
            System.out.println("Exception "+E);
            }

        }
}



