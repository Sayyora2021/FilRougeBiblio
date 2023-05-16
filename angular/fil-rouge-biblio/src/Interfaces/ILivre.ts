import { IAuteur } from "./IAuteur";
import { IExemplaire } from "./IExemplaire";
import { ITheme } from "./ITheme";
import { IMotClef } from "./MotClef";

export interface ILivre {
    id: number,
    iSBN: string,
    titre: string,
    themes: ITheme[],
    tags: IMotClef[],
    auteurs: IAuteur[],
    exemplaires: IExemplaire
}