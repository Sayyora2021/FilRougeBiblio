import { Component, OnInit } from '@angular/core';
import { ILivre } from 'src/Interfaces/ILivre';
import { IAuteur} from 'src/Interfaces/IAuteur';
import { ITheme } from 'src/Interfaces/ITheme';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { Router } from '@angular/router';
import { LivresService } from 'src/Services/livres.service';
import { AuteurService } from 'src/Services/auteur.service';
import { ThemesService } from 'src/Services/themes.service';
import { MotclefsService } from 'src/Services/motclefs.service';

@Component({
  selector: 'app-livres-list-full',
  templateUrl: './livres-list-full.component.html',
  styleUrls: ['./livres-list-full.component.css']
})
export class LivresListFullComponent implements OnInit {
  
  livres?: ILivre[];
  nomFiltre: string = '';

  constructor(private livresService:LivresService, private auteursService:AuteurService, private themesService:ThemesService, private motclefService:MotclefsService) { }

  ngOnInit(): void {
    this.livresService.listAll().subscribe(data => { this.livres = data; console.log(data) })
  }
  
  delete(livre:ILivre) {
    this.livresService.delete(livre.id);
    this.livres?.splice(this.livres.indexOf(livre));
  }

  filtrer() {
    if (this.nomFiltre && this.nomFiltre.trim() !== '') {
      if (this.livres)
        this.livres = this.livres.filter(livre =>
          livre.titre.toLowerCase().includes(this.nomFiltre.toLowerCase())
        );
    } else {
      this.livres = this.livres;
    }
  }

}
