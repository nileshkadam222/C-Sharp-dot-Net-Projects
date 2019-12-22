/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package ser;

import DB.BusDB;
import DB.LogDB;
import ModelClass.BusBean;
import ModelClass.LogBean;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author ind
 */
public class Client_Ser extends HttpServlet {
   
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
         String tag=request.getParameter("do");
            LogBean logbean=new LogBean();
        LogDB logdb=new LogDB();
          BusBean bus_info=new BusBean();
        BusDB busdb=new BusDB();
        int counter=0;
        try {

         
            if("insert".equals(tag)){
                counter=0;
                     String usr_name=request.getParameter("username");
                     String username=request.getParameter("name");
                     String user_city=request.getParameter("city");
                     String email_id=request.getParameter("email");
                     logbean.setName(usr_name);
                     logbean.setUser(username);
                     
                     logbean.setCity(user_city);
                     logbean.setEmailID(email_id);
                     counter=logdb.UpdateClient(logbean);
                     
            }

        } finally { 
            out.close();
        }
    } 

    

}
