import { IAuteur } from "./IAuteur";
import { IExemplaire } from "./IExemplaire";
import { ITheme } from "./ITheme";
import { IMotClef } from "./IMotClef";

export interface ILivre {
    Id: number,
    ISBN: string,
    Titre: string,
    Themes: ITheme[],
    Tags: IMotClef[],
    Auteurs: IAuteur[],
    Exemplaires: IExemplaire
}