﻿[Parameter] public VybaveniModel Item { get; set; }


if(item.EditMod == false)
            {

    if(item.PotrebujeRevizi == true)
                {
                    <tr style = "background-color:red">
 
                         <td> @item.Jmeno </td>
 
                         < td > @item.DatumKoupeni </ td >
 
                         < td > @item.PosledniDatumRevize </ td >
 
                         < td > @item.PotrebujeRevizi </ td >
 
                         < td >
 
                             < button style = "color:forestgreen" @onclick = "@(() => Revize(item))" > Make a revison</ button >
        
                                </ td >
        
                                < td >
        
                                    < button style = "color:red" @onclick = "@(() => Remove(item))" > Remove </ button >
           
                                   </ td >
           
                                   < td >
           
                                       < button style = "color:blue" @onclick = "() => item.EditMod = true" > Edit ✏️</ button >
                  
                                          </ td >
                  

                                      </ tr >
                }
                else
    {
                    < tr >
                        < td > @item.Jmeno </ td >
                        < td > @item.DatumKoupeni </ td >
                        < td > @item.PosledniDatumRevize </ td >
                        < td > @item.PotrebujeRevizi </ td >
                        < td >
                            < button style = "color:forestgreen" @onclick = "@(() => Revize(item))" > Make a revison</ button >
       
                               </ td >
       
                               < td >
       
                                   < button style = "color:red" @onclick = "@(() => Remove(item))" > Remove </ button >
          
                                  </ td >
          
                                  < td >
          
                                      < button style = "color:blue" @onclick = "() => item.EditMod = true" > Edit ✏️</ button >
                 
                                         </ td >
                 

                                     </ tr >

                }

}
            else
{




    @if(item.PotrebujeRevizi == true)
                {


                    < tr >
                        < td >< input class= "border-2 border-slate-300" @bind - value = item.Jmeno /> </ td >
    
                            < td >< input class= "border-2 border-slate-300" @bind - value = item.DatumKoupeni /> </ td >
        
                                < td >< input class= "border-2 border-slate-300" @bind - value = item.PosledniDatumRevize /> </ td >
            
                                    < td > @item.PotrebujeRevizi </ td >
            

                                    < td >
            
                                        < button style = "color:blue" @onclick = "@(() => Revize2(item))" > OK </ button >
               
                                       </ td >
               

                                   </ tr >
                }
                else
{
                    < tr style = "background-color:red" >
 
                         < td >< input class= "border-2 border-slate-300" @bind - value = item.Jmeno /> </ td >
     
                             < td >< input class= "border-2 border-slate-300" @bind - value = item.DatumKoupeni /> </ td >
         
                                 < td >< input class= "border-2 border-slate-300" @bind - value = item.PosledniDatumRevize /> </ td >
             
                                     < td > @item.PotrebujeRevizi </ td >
             

                                     < td >
             
                                         < button style = "color:blue" @onclick = "@(() => Revize2(item))" > OK </ button >
                
                                        </ td >
                

                                    </ tr >

                }

            }