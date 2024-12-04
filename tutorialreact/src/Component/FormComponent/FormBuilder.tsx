import React, { useState } from 'react';
import './FormBuilder.css';

interface FormField<T> {
  label: string;
  type: 'text' | 'email' | 'number' | 'password' | 'textarea' | 'checkbox' | 'select' | 'file';
  name: keyof T; // Limiter le nom aux clés de l'interface générique T
  options?: string[]; // Nécessaire pour les champs `select`
}

interface FormWrapperProps<T> {
  fields: FormField<T>[]; // Liste des champs basés sur T
  initialValues: T; // Valeurs initiales du formulaire
  onSubmit: (formData: T) => void; // Callback avec les données fortement typées
}

const FormWrapper = <T extends Record<string, unknown>>({
  fields,
  initialValues,
  onSubmit,
}: FormWrapperProps<T>) => {
  const [formData, setFormData] = useState<T>(initialValues);

  const handleInputChange = (name: keyof T, value: unknown) => {
    setFormData((prev) => ({ ...prev, [name]: value }));
  };

  const handleFileChange = (name: keyof T, files: FileList | null) => {
    if (files) {
      handleInputChange(name, files[0]); // Capturer uniquement le premier fichier
    }
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    onSubmit(formData);
  };

  return (
    <form className="columns-1 px-10 my-4" onSubmit={handleSubmit}>
      {fields.map((field) => (
        <div key={String(field.name)} className="form-group my-4">
          <label className="mx-3" htmlFor={String(field.name)}>
            {field.label}
          </label>
          {field.type === 'select' ? (
            <select
              id={String(field.name)}
              value={String(formData[field.name])}
              onChange={(e) => handleInputChange(field.name, e.target.value)}
            >
              {field.options?.map((option) => (
                <option key={option} value={option}>
                  {option}
                </option>
              ))}
            </select>
          ) : field.type === 'textarea' ? (
            <textarea
              id={String(field.name)}
              value={String(formData[field.name])}
              onChange={(e) => handleInputChange(field.name, e.target.value)}
            />
          ) : field.type === 'file' ? (
            <input
              id={String(field.name)}
              type="file"
              onChange={(e) => handleFileChange(field.name, e.target.files)}
            />
          ) : (
            <input
              id={String(field.name)}
              type={field.type}
              value={
                field.type === 'checkbox' ? undefined : String(formData[field.name])
              }
              checked={field.type === 'checkbox' ? Boolean(formData[field.name]) : undefined}
              onChange={(e) =>
                handleInputChange(
                  field.name,
                  field.type === 'checkbox' ? e.target.checked : e.target.value
                )
              }
            />
          )}
        </div>
      ))}
      <button className="bg-red-200" type="submit">
        Submit
      </button>
    </form>
  );
};

export default FormWrapper;
