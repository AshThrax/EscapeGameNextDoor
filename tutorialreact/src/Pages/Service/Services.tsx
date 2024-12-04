
import { FC } from "react";

import Servicejson from '../../assets/Json/service.json';
import { SectionWrapper } from "@/Component/Section/Section";

const Service =  () =>
{
    //const [service,setService] = useState([]);
    const rows: JSX.Element[]  = [];
    /*
    useEffect(()=>{
        const getservices= async ()=>
            {
                try 
                {
                const {data} =await axios.get(Servicejson.)
                setService(data.result)
                console.log(service);
                }catch(error)
                {
                    console.log(error);
                }
        };
        getservices();
    },[]);
    */
    Servicejson.forEach(element => {
        rows.push(< SectionWrapper Title={element.title} 
                             content={element.description}
                            indicatore={Number.parseInt(element.placement)}
                            uri={element.uri}>
                                <img src={element.uri} /> 
                        </SectionWrapper>)
    });
    return(

    <>
        <div>
            <h1>Service</h1>
            {rows}
        </div>
    </>
    )
};

interface IServiceDisplay
{
    Title: string;
    Description:string;
    placement: number;
    uri:string
}
export default Service;

export const ServiceDisplay : FC<IServiceDisplay> = ({Title,Description,placement,uri}) => {
    
    if(placement % 2 ==0 )
        return(
            <div key={placement}  className="columns-2 text-center">
                <div className="mx-10">
                    <div className="text-center">
                                <img className="max-w-none" src={uri} />
                            </div>
                </div>
                <br />
                <div className="mx-10">
                    <h3>{Title}</h3>
                    <p className="lead">{Description}</p>
                </div>
                <hr className="p-2 m-3" />
        </div>
    );
   
    else
    {
        return(
            <div key={placement}>
                <div className="columns-2 text-center">
                    <div className="">
                        <h1>{Title}</h1>
                        <p className="lead">{Description}</p>
                    </div>
                    <br />
                    <div className="">
                        <div className="text-center">
                            <img className="card-img rounded-2" src={uri} />
                        </div>
                        
                    </div>
                    <hr className="p-2 m-3" />
                </div>

            </div>
        );

    }
};