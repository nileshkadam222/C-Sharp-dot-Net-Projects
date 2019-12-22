/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package DB;

import ModelClass.BusBean;
import Conn.GenUtility;
import ModelClass.LogBean;
import ModelClass.SchBean;
import java.sql.*;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import  java.util.Date;


/**
 *
 * @author ind
 */
public class BusDB {
    Connection conn=null;
    PreparedStatement ps=null;
    ResultSet rs=null;
    Statement st=null;
    GenUtility gen=new GenUtility();
    String sql="";


    public int  InsertBusDT(BusBean bus_info){
          
           boolean flag=false;
           int count=0;
           try{
               DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
       //get current date time with Date()
            Date date = new Date();
            String dt1=dateFormat.format(date);


              sql="select num from bus_detail where num='"+bus_info.getNo()+"'";
                System.out.println("sql "+sql);
                conn=gen.dbconnection();
                 ps=(PreparedStatement) conn.prepareStatement(sql);
                 rs=ps.executeQuery();
                     while(rs.next()){
                        count=1;

                      }
         //        System.out.println();
                 if(count==0){
                 sql="insert into bus_detail(num,from1,to1,Type1,DT) "
	        +"values('"+bus_info.getNo()+"','"+bus_info.getFrom()+"','"+bus_info.getTo()+"','"+bus_info.getType()+"','"+dt1+"')";
                
                ps=(PreparedStatement) conn.prepareStatement(sql);
                ps.executeUpdate();
               sql="select num from bus_detail where num='"+bus_info.getNo()+"'";
                 ps=(PreparedStatement) conn.prepareStatement(sql);
                rs=ps.executeQuery();
                while(rs.next()){
                count=3;

                }
                 }
               

                
                System.out.println("count at insertbus "+count);

                }catch(Exception E){
                    System.out.println("Exception at insertBUs "+E);
                }
           return count;
    }
    public int insertSch(SchBean schbean){
        int count=0;
        String frm="",to="";
        try{
            DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
       //get current date time with Date()
            Date date = new Date();
            String dt1=dateFormat.format(date);
            sql="select from1,to1 from bus_detail where num='"+schbean.getBusno()+"'";
             conn=gen.dbconnection();
          ps=(PreparedStatement) conn.prepareStatement(sql);
          rs=ps.executeQuery();
           while(rs.next()){
               frm=rs.getString(1);
               to=rs.getString(2);
           }


          sql="select * from bus_sch where busno='"+schbean.getBusno()+"' and travel_dt='"+schbean.getTravel_time()+"' and frm='"+frm+"' and to1='"+to+"' and price="+schbean.getPrice()+" and event_time='"+schbean.getEventTm()+"'";
          
          ps=(PreparedStatement) conn.prepareStatement(sql);
          rs=ps.executeQuery();
          while(rs.next()){
                        count=1;

           }
           if(count==0){
          sql="insert into bus.bus_sch (busno,travel_dt,frm,scr_time,to1,to_time,price,event_time)"
          +" values('"+schbean.getBusno()+"','"+schbean.getTravel_time()+"','"+frm+"','"+schbean.getScr_time()+"','"+to+"','"+schbean.getDest_time()+"',"+schbean.getPrice()+",'"+schbean.getEventTm()+"')";

         // System.out.println("sql "+sql);
           ps=conn.prepareStatement(sql);
              ps.executeUpdate();
               sql="select * from bus_sch where busno='"+schbean.getBusno()+"' and travel_dt='"+schbean.getTravel_time()+"' and frm='"+frm+"' and to1='"+to+"' and price="+schbean.getPrice()+" and event_time='"+schbean.getEventTm()+"'";

                 ps=(PreparedStatement) conn.prepareStatement(sql);
                rs=ps.executeQuery();
                while(rs.next()){
                        count=2;

                    }
          }
          
           ////also insert into bus_servtatin table
          for(int i=1;i<=35;i++){
           sql="insert into bus.bus_reserv(busno,travel_dt,seatno,event_time,tag,dt)"
           + "values('"+schbean.getBusno()+"','"+schbean.getTravel_time()+"',"+i+",'"+schbean.getEventTm()+"','1','"+dt1+"')";
             ps=conn.prepareStatement(sql);
             ps.executeUpdate();
          }
   //    System.out.println("sq "+sql);
        }catch(Exception E){
            System.out.print("insertSch "+E);
        }
        return count;
    }

    public int insertFeedBack(String nae,String id ,String msg){
        int count=0;
        try{
            sql="select * from feedbacktable where name='"+nae+"' and email='"+id+"' and msg='"+msg+"'";
             conn=gen.dbconnection();
             ps=(PreparedStatement) conn.prepareStatement(sql);
             rs=ps.executeQuery();
          while(rs.next()){
                        count=1;

           }
            //  System.out.println("after") ;
             if(count==0){
               sql="insert into feedbacktable(name,email,msg,tag) values('"+nae+"','"+id+"','"+msg+"','N')";
                System.out.println("inside");
               ps=conn.prepareStatement(sql);
               ps.executeUpdate();
             sql="select * from feedbacktable where name='"+nae+"' and email='"+id+"' and msg='"+msg+"'";
              ps=(PreparedStatement) conn.prepareStatement(sql);
             rs=ps.executeQuery();
             while(rs.next()){
               count=2;

              }

             }
              //  System.out.println("after2");
           

        }catch(Exception E){
            System.out.println("Exception  at contact "+E);
        }
        return count;
    }

    public int insertlocMap(String bus,String pickpoint,String point_time,float price){
          conn=gen.dbconnection();
          int count=0;
        try{
             DateFormat dateFormat = new SimpleDateFormat("yyyy/MM/dd HH:mm:ss");
       //get current date time with Date()
            Date date = new Date();
            String dt1=dateFormat.format(date);
             sql="select * from bus_path where bus_no='"+bus+"' and point='"+pickpoint+"'";
              ps=(PreparedStatement) conn.prepareStatement(sql);
              rs=ps.executeQuery();
             while(rs.next()){
               count=1;

              }

             if(count==0){
                 sql="insert into bus.bus_path (bus_no,point,point_time,price,dt)"
                 +"values('"+bus+"','"+pickpoint+"','"+point_time+"',"+price+",'"+dt1+"')";

             ps=conn.prepareStatement(sql);
               ps.executeUpdate();
                sql="select * from bus_path where bus_no='"+bus+"' and point='"+pickpoint+"'";
              ps=(PreparedStatement) conn.prepareStatement(sql);
              rs=ps.executeQuery();
             while(rs.next()){
               count=2;

              }

             }
            
        }catch(Exception E){
            System.out.println("Exception at insertMap "+E);
        }
          return count;
      }
}
