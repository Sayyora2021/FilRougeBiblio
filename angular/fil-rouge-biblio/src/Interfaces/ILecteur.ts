import { IEmprunt } from "./IEmprunt";

export interface ILecteur {
    id: number,
    nom: string,
    prenom: string,
    email: string,
    telephone: string,
    adresse: string,
    cotisation: boolean,
    listEmprunts: IEmprunt[]
}