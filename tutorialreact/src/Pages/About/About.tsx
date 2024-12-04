import React, { FC } from "react";
import {
    Card,
    CardContent,
    CardDescription,
    CardFooter,
    CardHeader,
    CardTitle,
  } from "@/components/ui/card"
  
interface AboutInformation
{
    Title:string;
    Content:string;
    img:string;
    link: string;
}
const TableContact = [
    {"title":"hello","img":"/src/assets/img/depositphotos_129544134-stock-photo-yellow-road-signs.jpg", "content":"Lorem ipsum, dolor sit amet consectetur adipisicing elit. Alias iure magnam at molestias libero sunt fugiat, laboriosam tempora aliquam earum blanditiis quibusdam fugit hic sit deleniti quod impedit. Delectus, iure.","link":""},
    {"title":"hello","img":"/src/assets/img/depositphotos_129544134-stock-photo-yellow-road-signs.jpg", "content":"Lorem ipsum, dolor sit amet consectetur adipisicing elit. Alias iure magnam at molestias libero sunt fugiat, laboriosam tempora aliquam earum blanditiis quibusdam fugit hic sit deleniti quod impedit. Delectus, iure.","link":""},
    {"title":"hello","img":"/src/assets/img/depositphotos_129544134-stock-photo-yellow-road-signs.jpg", "content":"Lorem ipsum, dolor sit amet consectetur adipisicing elit. Alias iure magnam at molestias libero sunt fugiat, laboriosam tempora aliquam earum blanditiis quibusdam fugit hic sit deleniti quod impedit. Delectus, iure.","link":""}
]
const AboutPage: React.FC = () => 
{
    return(
        
   <>
        <h1 className="pb-10 
                        text-ellipsis 
                        text-center">About page</h1>
        <hr className=" color-red-600"/>
        <div className="container text-center">
            <br />
            <div className="columns-3 pt-10">
              {TableContact.map((item : AboutInformation)=> {
                return(
                    <CustopmCardabout 
                                Title={item.Title}
                                Content={item.Content}
                                link={item.link} 
                                img={item.img}/>
                );
              })}
            </div>
        </div>
    </>
    );
}  

export default AboutPage;

const CustopmCardabout: FC<AboutInformation>=({Title,Content,img,link})=> 
{
    return(
    <>
        <Card>
        <CardHeader>
            <CardTitle>{Title}</CardTitle>
            <CardDescription>Card Description</CardDescription>
        </CardHeader>
        <CardContent>
            <img src={img} alt="" />
        
        </CardContent>
        <CardContent>
          
            <p>{Content}</p>
        </CardContent>
        <CardContent>
           <button className="place-items-center" onClick={() => window.location=link}> link</button>
        </CardContent>
        <CardFooter>
        </CardFooter>
        </Card>

    </>);
}