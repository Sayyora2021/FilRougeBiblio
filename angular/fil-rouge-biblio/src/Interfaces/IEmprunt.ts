import { IExemplaire } from "./IExemplaire";
import { ILecteur } from "./ILecteur";

export interface IEmprunt {
    id: number,
    exemplaire: IExemplaire,
    lecteur: ILecteur,
    dateEmprunt: Date,
    dateRetour: Date,
    dateRetourReel: Date
}