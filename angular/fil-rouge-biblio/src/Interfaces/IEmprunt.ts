import { IExemplaire } from "./IExemplaire";
import { ILecteur } from "./ILecteur";

export interface IEmprunt {
    Id: number,
    Exemplaire: IExemplaire,
    Lecteur: ILecteur,
    DateEmprunt: Date,
    DateRetour: Date,
    DateRetourReel: Date
}