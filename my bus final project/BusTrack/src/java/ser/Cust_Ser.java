/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package ser;

import DB.CustDB;
import ModelClass.CustBean;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import org.apache.catalina.Session;

/**
 *
 * @author ind
 */
public class Cust_Ser extends HttpServlet {

    /** 
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code> methods.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void service(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();
        String content = request.getParameter("do");
        HttpSession session = request.getSession();

        CustBean cust = new CustBean();
        CustDB custdb = new CustDB();



       
        try {
            if ("payment".equals(content)) {
                 String username_sess = (String) session.getAttribute("userid");
                String no_passenger = (String) session.getAttribute("ser_passenger");
                String bustype = (String) session.getAttribute("ser_bus_type");
                String travel_dt = (String) session.getAttribute("ser_travel_dt");
                String bus_no = (String) session.getAttribute("pay_bus_no");

                String fare = (String) session.getAttribute("seatprice");
                System.out.println("fare " + fare);
                float price = Float.parseFloat(fare);


                int no = Integer.parseInt(no_passenger);
                String name1 = "", name2 = "", name3 = "", name4 = "", name5 = "", name6 = "";
                String gender1 = "", gender2 = "", gender3 = "", gender4 = "", gender5 = "", gender6 = "";
                String age1 = "", age2 = "", age3 = "", age4 = "", age5 = "", age6 = "";
                String SeatList = (String) session.getAttribute("seat_list");
                String[] Seat_Array = SeatList.split(":");
                System.out.println("array " + Seat_Array.length);

                for (int i = 0; i < Seat_Array.length; i++) {
                    System.out.println(" passenger " + Seat_Array[i]);
                }

                if (no == 1) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");
                } else if (no == 2) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                } else if (no == 3) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                } else if (no == 4) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                    name4 = request.getParameter("name4");
                    gender4 = request.getParameter("gender4");
                    age4 = request.getParameter("age4");

                } else if (no == 5) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                    name4 = request.getParameter("name4");
                    gender4 = request.getParameter("gender4");
                    age4 = request.getParameter("age4");

                    name5 = request.getParameter("name5");
                    gender5 = request.getParameter("gender5");
                    age5 = request.getParameter("age5");


                } else if (no == 6) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                    name4 = request.getParameter("name4");
                    gender4 = request.getParameter("gender4");
                    age4 = request.getParameter("age4");

                    name5 = request.getParameter("name5");
                    gender5 = request.getParameter("gender5");
                    age5 = request.getParameter("age5");

                    name6 = request.getParameter("name6");
                    gender6 = request.getParameter("gender6");
                    age6 = request.getParameter("age6");

                }
                String mob = request.getParameter("mobile");
                String email = request.getParameter("emailid");
                String card_no = request.getParameter("cardno");
                String card_name = request.getParameter("cardname");
                String CWW = request.getParameter("cardcww");

                System.out.println("name1 " + name1 + " gender1 " + gender1 + " age1 " + age1 + " mob " + mob + " no " + no);
                if (no == 1) {
                    System.out.println("no==1");
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                } else if (no == 2) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);


                } else if (no == 3) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                } else if (no == 4) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name4);
                    cust.setGender(gender4);
                    cust.setAge(age4);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[3]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                } else if (no == 5) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setPrice(price);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name4);
                    cust.setGender(gender4);
                    cust.setAge(age4);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[3]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);
                    ///--- 5--
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name5);
                    cust.setGender(gender5);
                    cust.setAge(age5);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[4]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);


                } else if (no == 6) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setPrice(price);
                    cust.setCWW(CWW);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name4);
                    cust.setGender(gender4);
                    cust.setAge(age4);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[3]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    ///--- 5--
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name5);
                    cust.setGender(gender5);
                    cust.setAge(age5);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[4]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);
                    /// --- 6 ---
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name6);
                    cust.setGender(gender6);
                    cust.setAge(age6);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[5]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);
                }
                response.sendRedirect("payent_done.jsp");
            } else if ("payment_log".equals(content)) {
                String no_passenger = (String) session.getAttribute("ser_passenger_log");
                String bustype = (String) session.getAttribute("ser_bus_type_log");
                String travel_dt = (String) session.getAttribute("ser_travel_dt_log");
                String bus_no = (String) session.getAttribute("pay_bus_no_log");
                String fare = (String) session.getAttribute("seatprice_log");
                 String username_sess = (String) session.getAttribute("userid_new");
                System.out.println("fare " + fare);
                float price = Float.parseFloat(fare);

                int no = Integer.parseInt(no_passenger);
                String name1 = "", name2 = "", name3 = "", name4 = "", name5 = "", name6 = "";
                String gender1 = "", gender2 = "", gender3 = "", gender4 = "", gender5 = "", gender6 = "";
                String age1 = "", age2 = "", age3 = "", age4 = "", age5 = "", age6 = "";
                String SeatList = (String) session.getAttribute("seat_list_log");
                String[] Seat_Array = SeatList.split(":");
                System.out.println("array " + Seat_Array.length);

                for (int i = 0; i < Seat_Array.length; i++) {
                    System.out.println(" passenger " + Seat_Array[i]);
                }

                if (no == 1) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");
                } else if (no == 2) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                } else if (no == 3) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                } else if (no == 4) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                    name4 = request.getParameter("name4");
                    gender4 = request.getParameter("gender4");
                    age4 = request.getParameter("age4");

                } else if (no == 5) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                    name4 = request.getParameter("name4");
                    gender4 = request.getParameter("gender4");
                    age4 = request.getParameter("age4");

                    name5 = request.getParameter("name5");
                    gender5 = request.getParameter("gender5");
                    age5 = request.getParameter("age5");


                } else if (no == 6) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                    name4 = request.getParameter("name4");
                    gender4 = request.getParameter("gender4");
                    age4 = request.getParameter("age4");

                    name5 = request.getParameter("name5");
                    gender5 = request.getParameter("gender5");
                    age5 = request.getParameter("age5");

                    name6 = request.getParameter("name6");
                    gender6 = request.getParameter("gender6");
                    age6 = request.getParameter("age6");

                }
                String mob = request.getParameter("mobile");
                String email = request.getParameter("emailid");
                String card_no = request.getParameter("cardno");
                String card_name = request.getParameter("cardname");
                String CWW = request.getParameter("cardcww");

                System.out.println("name1 " + name1 + " gender1 " + gender1 + " age1 " + age1 + " mob " + mob + " no " + no);
                if (no == 1) {
                    System.out.println("no==1");
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                } else if (no == 2) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);


                } else if (no == 3) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                } else if (no == 4) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name4);
                    cust.setGender(gender4);
                    cust.setAge(age4);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[3]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                } else if (no == 5) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setPrice(price);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name4);
                    cust.setGender(gender4);
                    cust.setAge(age4);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[3]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);
                    ///--- 5--
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name5);
                    cust.setGender(gender5);
                    cust.setAge(age5);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[4]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);


                } else if (no == 6) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setPrice(price);
                    cust.setCWW(CWW);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name4);
                    cust.setGender(gender4);
                    cust.setAge(age4);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[3]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    ///--- 5--
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name5);
                    cust.setGender(gender5);
                    cust.setAge(age5);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[4]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);
                    /// --- 6 ---
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name6);
                    cust.setGender(gender6);
                    cust.setAge(age6);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[5]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);
                }
                response.sendRedirect("payent_done_log.jsp");
            }else if ("payment_sign".equals(content)) {
                String no_passenger = (String) session.getAttribute("ser_passenger_log");
                String bustype = (String) session.getAttribute("ser_bus_type_log");
                String travel_dt = (String) session.getAttribute("ser_travel_dt_log");
                String bus_no = (String) session.getAttribute("pay_bus_no_sign");
                String fare = (String) session.getAttribute("seatprice_sign");
                 String username_sess = (String) session.getAttribute("userid_visit_sign");
                System.out.println("fare " + fare);
                float price = Float.parseFloat(fare);

                int no = Integer.parseInt(no_passenger);
                String name1 = "", name2 = "", name3 = "", name4 = "", name5 = "", name6 = "";
                String gender1 = "", gender2 = "", gender3 = "", gender4 = "", gender5 = "", gender6 = "";
                String age1 = "", age2 = "", age3 = "", age4 = "", age5 = "", age6 = "";
                String SeatList = (String) session.getAttribute("seat_list_sign");
                String[] Seat_Array = SeatList.split(":");
                System.out.println("array " + Seat_Array.length);

                for (int i = 0; i < Seat_Array.length; i++) {
                    System.out.println(" passenger " + Seat_Array[i]);
                }

                if (no == 1) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");
                } else if (no == 2) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                } else if (no == 3) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                } else if (no == 4) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                    name4 = request.getParameter("name4");
                    gender4 = request.getParameter("gender4");
                    age4 = request.getParameter("age4");

                } else if (no == 5) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                    name4 = request.getParameter("name4");
                    gender4 = request.getParameter("gender4");
                    age4 = request.getParameter("age4");

                    name5 = request.getParameter("name5");
                    gender5 = request.getParameter("gender5");
                    age5 = request.getParameter("age5");


                } else if (no == 6) {
                    name1 = request.getParameter("name1");
                    gender1 = request.getParameter("gender1");
                    age1 = request.getParameter("age1");

                    name2 = request.getParameter("name2");
                    gender2 = request.getParameter("gender2");
                    age2 = request.getParameter("age2");

                    name3 = request.getParameter("name3");
                    gender3 = request.getParameter("gender3");
                    age3 = request.getParameter("age3");

                    name4 = request.getParameter("name4");
                    gender4 = request.getParameter("gender4");
                    age4 = request.getParameter("age4");

                    name5 = request.getParameter("name5");
                    gender5 = request.getParameter("gender5");
                    age5 = request.getParameter("age5");

                    name6 = request.getParameter("name6");
                    gender6 = request.getParameter("gender6");
                    age6 = request.getParameter("age6");

                }
                String mob = request.getParameter("mobile");
                String email = request.getParameter("emailid");
                String card_no = request.getParameter("cardno");
                String card_name = request.getParameter("cardname");
                String CWW = request.getParameter("cardcww");

                System.out.println("name1 " + name1 + " gender1 " + gender1 + " age1 " + age1 + " mob " + mob + " no " + no);
                if (no == 1) {
                    System.out.println("no==1");
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                } else if (no == 2) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);


                } else if (no == 3) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                } else if (no == 4) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name4);
                    cust.setGender(gender4);
                    cust.setAge(age4);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[3]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                } else if (no == 5) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setPrice(price);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name4);
                    cust.setGender(gender4);
                    cust.setAge(age4);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[3]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);
                    ///--- 5--
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name5);
                    cust.setGender(gender5);
                    cust.setAge(age5);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[4]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);


                } else if (no == 6) {
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name1);
                    cust.setGender(gender1);
                    cust.setAge(age1);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[0]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    ////for 1
                    custdb.insertCustReserv(cust);
                    /////--------------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name2);
                    cust.setGender(gender2);
                    cust.setAge(age2);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[1]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name3);
                    cust.setGender(gender3);
                    cust.setAge(age3);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[2]);
                    cust.setPrice(price);
                    cust.setCWW(CWW);
                    custdb.insertCustReserv(cust);

                    /////--------3------------
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name4);
                    cust.setGender(gender4);
                    cust.setAge(age4);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[3]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);

                    ///--- 5--
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name5);
                    cust.setGender(gender5);
                    cust.setAge(age5);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[4]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);
                    /// --- 6 ---
                    cust.setUsername(username_sess);
                    cust.setBusno(bus_no);
                    cust.setTravelDt(travel_dt);
                    cust.setCustname(name6);
                    cust.setGender(gender6);
                    cust.setAge(age6);
                    cust.setMob(mob);
                    cust.setEmailid(email);
                    cust.setCardname(card_name);
                    cust.setCardno(card_no);
                    cust.setSeatNo(Seat_Array[5]);
                    cust.setCWW(CWW);
                    cust.setPrice(price);
                    custdb.insertCustReserv(cust);
                }

                System.out.println("inside sign");
                response.sendRedirect("payent_done_sign.jsp");
            }
        } catch (Exception E) {
            System.out.println("Exception " + E);
        }
    }
}
