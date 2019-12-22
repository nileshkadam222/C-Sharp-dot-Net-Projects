package ser;
import DB.BusDB;
import DB.LogDB;
import ModelClass.BusBean;
import ModelClass.LogBean;
import ModelClass.SchBean;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import org.apache.catalina.Session;

public class Admin_Ser extends HttpServlet {
   
    /** 
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code> methods.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
       static public int counter_sch=0;
       static public int new_bus=0;
       ///112
       static public int new_agent=0;
       static public int new_user=0;
        static public int signup=0;
         static public int new_feedback=0;
            static public int new_loc=0;
    protected void service(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        String tag=request.getParameter("do");
        PrintWriter out = response.getWriter();
        BusBean bus_info=new BusBean();
        BusDB busdb=new BusDB();
        LogBean logbean=new LogBean();
        LogDB logdb=new LogDB();
        SchBean schbean=new SchBean();
        int counter=0;

        try {
              HttpSession session=request.getSession();
           if("insert".equals(tag)){
            //    System.out.println("  iiiii insert ");
                String no=request.getParameter("BusNo");
                String frm_src=request.getParameter("FromSource");
                String To_Src=request.getParameter("ToSource");
                String Type=request.getParameter("bustype");
                bus_info.setNo(no);
                bus_info.setFrom(frm_src);
                bus_info.setTo(To_Src);
                bus_info.setType(Type);
                 boolean flag=false;
                 int count=0;
                count=busdb.InsertBusDT(bus_info);
                if(count==3){
                  session.setAttribute("inser_bus_flag","Insert Data successfully");
                }else if(count==0) {
                     session.setAttribute("inser_bus_flag","Error while inserting");
                }else if(count==1){
                     session.setAttribute("inser_bus_flag","Duplicate Bus Number");
                }

                new_bus=1;
               
                response.sendRedirect("New_Bus.jsp");


            }else if("insert_user".equals(tag)){
                 // System.out.println("insert user ");
         //     name= user_name   
         // username=user   
         // pass= password   
         // city= city   
         // id= email
                     String usr_name=request.getParameter("user_name");
                     String username=request.getParameter("user");
                     String pass=request.getParameter("password");
                     String user_city=request.getParameter("city");
                     String email_id=request.getParameter("email");
                     
                     logbean.setName(usr_name);
                     logbean.setUser(username);
                     logbean.setPass(pass);
                     logbean.setCity(user_city);
                     logbean.setEmailID(email_id);
                     counter=logdb.inserUser(logbean);
                     if(counter==1){
                         session.setAttribute("ADD_USER","This username is already exits ");
                     }else if(counter==2){
                           session.setAttribute("ADD_USER","Data insert successfully.");
                     }
                     new_user=1;
                     response.sendRedirect("Add_user.jsp");
            }
            else if("insertagent".equals(tag)){
                 System.out.println("insert Client ");
                  String usr_name=request.getParameter("user_name");
                     String username=request.getParameter("user");
                     String pass=request.getParameter("password");
                     String user_city=request.getParameter("city");
                     String email_id=request.getParameter("email");

                     logbean.setName(usr_name);
                     logbean.setUser(username);
                     logbean.setPass(pass);
                     logbean.setCity(user_city);
                     logbean.setEmailID(email_id);
                     counter=logdb.inserAgent(logbean);
                       if(counter==1){
                         session.setAttribute("ADD_AGENT","This username is already exits ");
                     }else if(counter==2){
                           session.setAttribute("ADD_AGENT","Data insert successfully.");
                     }
                     new_agent=1;
                     response.sendRedirect("Add_agent.jsp");



            }
                else if("scheduleBus".equals(tag)){
                    //scheduleBus
                    String busno=request.getParameter("bussch");
                    String traveldt=request.getParameter("datepic");
                    String Hour=request.getParameter("Hr");
                    String Mins=request.getParameter("Min");
                    String Hour_to=request.getParameter("Hr_to");
                    String Mins_to=request.getParameter("Min_to");
                    String event=request.getParameter("time");
                    float price=Float.parseFloat(request.getParameter("price"));
                     schbean.setBusno(busno);
                     schbean.setScr_time(Hour+":"+Mins);
                     schbean.setDest_time(Hour_to+":"+Mins_to);
                     schbean.setTravel_time(traveldt);
                     schbean.setEventTm(event);
                     schbean.setPrice(price);

                      
                         counter=busdb.insertSch(schbean);
                         if(counter==2){
                            session.setAttribute("add_sch","Bus entry has been done successfully");
                         }else if(counter==1){
                              session.setAttribute("add_sch","Bus entry alerady exits ");
                         }
                   
                     counter_sch=1;
                    
                     response.sendRedirect("schedule_bus.jsp");
            }
              else if("signup".equals(tag)){
                String usr_name=request.getParameter("user_name");
                     String username=request.getParameter("user");
                     String pass=request.getParameter("password");
                     String user_city=request.getParameter("city");
                     String email_id=request.getParameter("email");

                     logbean.setName(usr_name);
                     logbean.setUser(username);
                     logbean.setPass(pass);
                     logbean.setCity(user_city);
                     logbean.setEmailID(email_id);
                     counter=logdb.Signup(logbean);
                     if(counter==1){
                         session.setAttribute("ADD_SIGNUP","This username is already exits ");
                     }else if(counter==2){
                           session.setAttribute("ADD_SIGNUP","Data insert successfully.");
                     }
                     signup=1;
                     response.sendRedirect("signup.jsp");
                  }
 else if("contactForm".equals(tag)){
     counter=0;
     String nae=request.getParameter("user_name");
     String id=request.getParameter("emailid");
     StringBuffer a=new StringBuffer();
     String msg=a.append(request.getParameter("msg")).toString();
     System.out.println(nae+" "+id +"  "+msg);
     counter=busdb.insertFeedBack(nae,id,msg);
       if(counter==1){
                         session.setAttribute("ADD_CONTACT","Same Feedback already provide by you ");
                     }else if(counter==2){
                          session.setAttribute("ADD_CONTACT","Data Saved successfully.");
                     }
                        new_feedback=1;
                        response.sendRedirect("contacts.jsp");
 } else if("locmapping".equals(tag)){
     String bus=request.getParameter("bussch");
     String Hour=request.getParameter("Hr");
     String Mins=request.getParameter("Min");
     String price=request.getParameter("price");
     String pickpoint=request.getParameter("pick");
     String point_time=Hour+":"+Mins;
     counter=busdb.insertlocMap(bus,pickpoint,point_time,Float.parseFloat(price));
     if(counter==1){
          session.setAttribute("ADD_LOC","This Pick up point is already exits ");
     }else if(counter==2){
        session.setAttribute("ADD_LOC","This Pick up point saved succesfully ");
     }
     new_loc=1;
        response.sendRedirect("loc_map.jsp");
 }
        } catch (Exception E){
            System.out.println("Exception "+E);
        }
        
    } 

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /** 
     * Handles the HTTP <code>GET</code> method.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
   

    /** 
     * Handles the HTTP <code>POST</code> method.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
   
    
 }
