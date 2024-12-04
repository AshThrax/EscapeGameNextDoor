import React from "react";

import Section, { SectionCenter, SectionWrapper } from "@/Component/Section/Section";


const HomePage: React.FC = () => 
{
    const lor = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Unde fugit commodi libero voluptatem et voluptatibus sapiente perferendis magnam officiis repellendus facere aspernatur, labore minima delectus officia asperiores recusandae consectetur deleniti."
    return(
        
   <div>
        <h1 className="">Home</h1>
        <hr className="my-10"/>
        <SectionCenter  Title="test lorem" content={lor} >
                <p>{lor}</p>
                <p>{lor}</p>
        </SectionCenter>
        <SectionWrapper Title={"Doom"} content={lor}  indicatore={3}>
            <div>
                <img className="rounded-md rounded-se-none"  src="/src/assets/img/depositphotos_129544134-stock-photo-yellow-road-signs.jpg" />
            </div>
        </SectionWrapper>
        <Section  Title={"lorem"} Content={lor} Img={"https://cdn-icons-png.flaticon.com/512/2175/2175188.png"} />
    </div>
    );
}  

export default HomePage;
