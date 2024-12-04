
import {FC} from "react";
import contactjson from '../../assets/Json/Contact.json'
import {
    Card,
    CardContent,
    CardDescription,
    CardFooter,
    CardHeader,
    CardTitle,
  } from "@/components/ui/card"
  
interface ContactItem
{
    Title:string;
    Description:string
    uri:string
    id:string;
    link:string
}
const Contact: FC= () =>
    {
       const ListCard= contactjson.map((item: ContactItem) => 
        {
            return(
                <CardCustom
                    id={item.id}
                    Title={item.Title}
                    Description={item.Description}
                    uri={item.uri}
                    link={item.link}
                    />
              ) 
       });
                    
        
        return(
        <>
            <div className="">
                <h1>Contact</h1>
            <div className="columns-3 my-5">
                {ListCard}
            </div>
            </div>
          
        </>
        )
    };
    

const CardCustom : FC<ContactItem> = ({Title,Description,uri,id,link}) => 
    {
        return(
        <>
          
            <Card key={id}>
                    <CardHeader>
                        <CardTitle >{Title}</CardTitle>
                    </CardHeader>
                    <CardContent>
                            <div className="place-center">
                                <img className="img-fluid" src={uri} alt="miaou" />
                            </div>
                            
                            <CardDescription>Card 

                                <p className="lead text-center">{Description}</p> 
                            </CardDescription>
                        <div className="items-center place-center columns-3xs">
                            <div></div>
                            <button className="bg-red-600  " onClick={() =>window.location.href= link } >check the link</button>
                            <div></div>
                        </div>
                    </CardContent>
                    <CardFooter>
                </CardFooter>
            </Card>
        </>
        )
    };
export default Contact;
