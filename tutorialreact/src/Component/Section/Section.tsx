
import "./Section.css";

interface SectionProps
{
    Title: string;
    Content: string;
    Img: string;
}


const Section: React.FC<SectionProps> = ({ Title, Content, Img }) => {
    return (
      <div className="grid grid-rows-3 grid-flow-col gap-4 m-10 text-start">
        <div className="row-span-3 place-items-center">
          <img className="w-16 md:w-32 lg:w-48 min-w-20" src={Img} alt="Section image" />
        </div>
        <div className="col-span-2">
          <h2>{Title}</h2>
          <hr/>
        </div>
        <div className="row-span-2 col-span-2">
          <p>{Content}</p>
        </div>
      </div>
    );
  };
  
  export default Section;

  const ReverseSection: React.FC<SectionProps> = ({ Title, Content, Img }) => {
    return (
      <div className="grid grid-rows-3 grid-flow-col gap-4 m-10 text-start">
        <div className="col-span-2">
          <h2>{Title}</h2>
          <hr/>
        </div>
        <div className="row-span-2 col-span-2">
          <p>{Content}</p>
        </div>
        <div className="row-span-3 place-items-center">
          <img className="w-16 md:w-32 lg:w-48" src={Img} alt="Section image" />
        </div>
      </div>
    );
  };
export {ReverseSection};
type SectionWrapper =
{
    indicatore: number ;
    Title:string;
    content:string;
    children:React.ReactNode
}

const SectionWrapper: React.FC<SectionWrapper> = ({ indicatore, Title, content,children }) => {
   if( indicatore %2 == 0 || null)
   {
       return (
         <div className="grid grid-rows-3 grid-flow-col gap-4 m-10 text-start">
           <div className="row-span-3 place-items-center">
             {children}
           </div>
           <div className="col-span-2 text-red-300">
             <h2>{Title}</h2>
             <hr/>
           </div>
           <div className="row-span-2 col-span-2">
             <p>{content}</p>
           </div>
         </div>
       );
   }
   else if(indicatore %2 !=0)
   {
    return(
    <div className="grid grid-rows-3 grid-flow-col gap-4 m-10">
        <div className="col-span-2 text-red-300">
            <h2 className="text-end">{Title}</h2>
            <hr/>
        </div>
        <div className="row-span-2 col-span-2 text-end">
            <p>{content}</p>
        </div>
        <div className="row-span-3 place-items-center text-start">
            {children}
        </div>
    </div>
        
    )
   }
   else{
    <p>Huh</p>
   }
  };
  
  export {SectionWrapper} ;

  const SectionCenter: React.FC<SectionWrapper>= ({Title,children }) => {
    
    {
        return (
          <div className="grid grid-cols-1 grid-flow-col gap-4text-start">
            <div className="row-span-3 place-items-center">
            </div>
            <div className="grid gap-4 row-span-3 text-red-300">
              <h2>{Title}</h2>
              <hr/>
                <div className="rows-start-2 text-start row-end-4 row-span-2 ">
                    {children}
                </div>
            </div>
            <div className="row-span-3 ">
            </div>
          </div>
        );
    }
}
export {SectionCenter};