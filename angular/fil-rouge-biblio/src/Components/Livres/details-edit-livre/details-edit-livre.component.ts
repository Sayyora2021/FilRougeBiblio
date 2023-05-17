import { Component, OnInit } from '@angular/core';
import { ILivre } from 'src/Interfaces/ILivre';
import { IAuteur} from 'src/Interfaces/IAuteur';
import { ITheme } from 'src/Interfaces/ITheme';
import { IMotClef } from 'src/Interfaces/IMotClef';
import { ActivatedRoute, Router } from '@angular/router';
import { LivresService } from 'src/Services/livres.service';
import { AuteurService } from 'src/Services/auteur.service';
import { ThemesService } from 'src/Services/themes.service';
import { MotclefsService } from 'src/Services/motclefs.service';

@Component({
  selector: 'app-details-edit-livre',
  templateUrl: './details-edit-livre.component.html',
  styleUrls: ['./details-edit-livre.component.css']
})
export class DetailsEditLivreComponent implements OnInit {

  constructor(private livresService:LivresService, private auteursService:AuteurService, private themesService:ThemesService, private motclefService:MotclefsService, private route: ActivatedRoute,private rout: Router) { }

  auteurs?: IAuteur[];
  themes?: ITheme[];
  tags?: IMotClef[];
  livre?: ILivre;

  ngOnInit(): void {
    let i = this.route.snapshot.paramMap.get('id');
    if(i != null) {
      let id = parseInt(i);
      this.livresService.details(id).subscribe(data => { console.log(data); this.livre = data; console.log('test');})
      this.auteursService.listAll().subscribe(data => { this.auteurs = data; console.log("Auteurs:"); console.log(data) })
      this.themesService.listAll().subscribe(data => { this.themes = data; console.log("Themes:"); console.log(data) })
      this.motclefService.listAll().subscribe(data => { this.tags = data; console.log("Mots clefs:"); console.log(data) })
    }
  }

  update() {
    if(this.livre != undefined)
    {
      this.livresService.update(this.livre);
      this.rout.navigate(['Livres'])
    }
  }
}
