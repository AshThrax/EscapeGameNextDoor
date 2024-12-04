import {
    AlertDialog,
    AlertDialogAction,
    AlertDialogCancel,
    AlertDialogContent,
    AlertDialogDescription,
    AlertDialogFooter,
    AlertDialogHeader,
    AlertDialogTitle,
    AlertDialogTrigger,
  } from "@/components/ui/alert-dialog";
import { Button } from "@/components/ui/button";
import React, { FC } from "react";

type TAlertWrapper ={
    name: string;
    children: React.ReactNode
}

const AlertDialogDemo : FC<TAlertWrapper>=({name,children}) => {
    {
        return (
         <AlertDialog >
           <AlertDialogTrigger asChild>
             <Button variant="outline">{name}</Button>
           </AlertDialogTrigger>
           <AlertDialogContent>
             <AlertDialogHeader>
               <AlertDialogTitle>Are you absolutely sure?</AlertDialogTitle>
               <AlertDialogDescription className="my-4">
                        {children}
               </AlertDialogDescription>
             </AlertDialogHeader>
             <AlertDialogFooter>
               <AlertDialogCancel>Cancel</AlertDialogCancel>
               <AlertDialogAction>Continue</AlertDialogAction>
             </AlertDialogFooter>
           </AlertDialogContent>
         </AlertDialog>
       )
    }
  }
  export default AlertDialogDemo ;