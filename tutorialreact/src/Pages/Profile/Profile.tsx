import { FC, useState } from 'react';
import './Profile.css';
import FormWrapper from '@/Component/FormComponent/FormBuilder';
import TAlertWrapper from '@/Component/Modal/ModalDialog';
import {useAuth0} from"@auth0/auth0-react";
import {Card,CardContent,CardDescription,CardFooter,CardHeader,CardTitle,} from '@/components/ui/card';
import SheetUser from '@/Component/Sheet/Sheet';



interface UserInfo {
  name: string;
  firstName: string;
  profilePicture: string | File;
  description: string;
  gender: string;
}

const initialProfileInfo: UserInfo = {
  name: 'Arthoris',
  firstName: 'bernardp',
  profilePicture: '/src/assets/img/depositphotos_129544134-stock-photo-yellow-road-signs.jpg',
  description: 'lorem ipsum, ipsmu sum sum',
  gender: 'M',
};

const Profile: FC = () => {
  const [profileInfo, setProfileInfo] = useState<UserInfo>(initialProfileInfo);

  const handleFormSubmit = (formData: UserInfo) => {
    console.log('Form Data:', formData);
    setProfileInfo(formData);
  };

    const { user, isAuthenticated, isLoading } = useAuth0();

  return (
    <>
      <div className=' my-5 bg-red-300'>
        
        {(isAuthenticated) ? <div>yes <p>{user?.given_name}</p></div> : <p>no</p> }
        
      </div>
      <div className=" columns-2  w-100">
        <div className='w-full aspect-square'>
          <Card>
              <CardHeader>
                  <CardTitle>User information</CardTitle>
                      <CardDescription>Card Description</CardDescription>
                        </CardHeader>
                            <CardContent>
                                <div className='flex w-100 place-items-center'>
                                    <img
                                          className="w-25 h-25 rounded-full object-cover place-content-center"
                                          src={
                                            typeof profileInfo.profilePicture === 'string'
                                              ? profileInfo.profilePicture
                                              : URL.createObjectURL(profileInfo.profilePicture)
                                          }
                                          alt="Profile"
                                        />
                                  </div>
                              </CardContent>
                <CardFooter>
                </CardFooter>
          </Card>
        </div>
          <div className=' w-full aspect-square col-span-2'>
            <Card>
                <CardHeader> 
                  <CardTitle>personnal information  
                    <div className='float-end'>
                      <SheetUser >
                                  <div>
                                      <div className='mb-4'>
                                          <ProfileFormData initialValues={profileInfo} onSubmit={handleFormSubmit} />
                                      </div>
                                      <div className='mb-4'>
                                          <EscapegameUserList/>
                                      </div>
                                </div>
                        </SheetUser>
                    </div>
                      </CardTitle>
                  <CardDescription>Card Description </CardDescription>
                  </CardHeader>
                        <CardContent className='grid gap-4'>
                        <div className="">
                              <div>
                                <p><strong>Name:</strong> {profileInfo.name}
                                  </p> 
                              </div>
                              <div>
                                  <p><strong>First Name:</strong> {profileInfo.firstName}
                                    </p>
                              </div>
                          
                            </div>
                        </CardContent>
                        <CardContent>
                          <div>
                              <h1><strong>Biography</strong></h1>
                                <p>{profileInfo.description}</p>
                          </div>
                  </CardContent>
                  <CardFooter>

                  </CardFooter>
            </Card>
          </div>
      </div>
    </>
  );
};

export const ProfileFormData: FC<{
  initialValues: UserInfo;
  onSubmit: (formData: UserInfo) => void;
}> = ({ initialValues, onSubmit }) => {
  const fields = [
    { label: 'Name', type: 'text', name: 'name' },
    { label: 'First Name', type: 'text', name: 'firstName' },
    { label: 'Profile Picture', type: 'file', name: 'profilePicture' },
    { label: 'Description', type: 'textarea', name: 'description' },
    { label: 'Gender', type: 'text', name: 'gender' },
  ] as const;

  return (
    <div>
        <div className='mb-4'>
                <TAlertWrapper  name='information profile'>
                    <FormWrapper<UserInfo> fields={fields} initialValues={initialValues} onSubmit={onSubmit} />
                </TAlertWrapper>
        </div>
    </div>
  );
};

const EscapegameUserList: FC= () => {
    return(
        <>
            <TAlertWrapper name='escapesgame'>
                <div>
                    escape
                </div>
            </TAlertWrapper>
        </>
    )
} 

export default Profile;
