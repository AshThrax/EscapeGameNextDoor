import {
    Sheet,
    SheetContent,
    SheetDescription,
    SheetHeader,
    SheetTitle,
    SheetTrigger,
  } from "@/components/ui/sheet"
import {FC} from'react';

type SheetWrapper = 
{
    children: React.ReactNode;
}

const SheetUser : FC<SheetWrapper> =({children}) =>{
        
        return(
            <>
                <Sheet>
                    <SheetTrigger> <p className="text-red-400">Open</p></SheetTrigger>
                    <SheetContent>
                        <SheetHeader>
                        <SheetTitle>Users Option</SheetTitle>
                        <SheetDescription>
                            <div> 
                             
                            {children}
                            </div>
                        </SheetDescription>
                        </SheetHeader>
                        <SheetHeader>
                        <SheetTitle>EscapeGame Option</SheetTitle>
                        <SheetDescription>
                           
                        </SheetDescription>
                        </SheetHeader>
                        
                    </SheetContent>
                </Sheet>
            </>
        )
}
export default SheetUser;

