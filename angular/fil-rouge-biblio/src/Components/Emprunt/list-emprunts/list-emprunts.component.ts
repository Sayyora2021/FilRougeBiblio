import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap, Router } from '@angular/router';
import { IEmprunt } from 'src/Interfaces/IEmprunt';
import { EmpruntService } from 'src/Services/emprunt.service';

@Component({
  selector: 'app-list-emprunts',
  templateUrl: './list-emprunts.component.html',
  styleUrls: ['./list-emprunts.component.css']
})
export class ListEmpruntsComponent implements OnInit {

  emprunts?: IEmprunt[];
  nomFiltre: string = '';

  constructor(private empruntService: EmpruntService, private router: Router, private activatedRoute: ActivatedRoute) {

  }

  ngOnInit(): void {

    this.activatedRoute.queryParamMap.subscribe((params: ParamMap) => {
      const search = params.get('search');
      if (search) {
        this.nomFiltre = search;
      }
      this.empruntService.listAll().subscribe(
        (data: IEmprunt[]) => {
          this.emprunts = data;
          this.filtrerEmpruntsExactName();
        });
    });


  }

  rendre(id: number) {
    this.empruntService.rendre(id);
    this.router.navigate(['Emprunts']);
  }

  filtrer() {
    if (this.nomFiltre && this.nomFiltre.trim() !== '') {
      if (this.emprunts)
        this.emprunts = this.emprunts.filter(emprunt =>
          emprunt.lecteur.nom.toLowerCase().includes(this.nomFiltre.toLowerCase())
        );
    } else {
      this.emprunts = this.emprunts;
    }
  }
  filtrerEmpruntsExactName() {
    if (this.nomFiltre && this.nomFiltre.trim() !== '') {
      if (this.emprunts)
        this.emprunts = this.emprunts.filter(emprunt =>
          emprunt.lecteur.nom.toLowerCase() == this.nomFiltre.toLowerCase()
        );
    } else {
      this.emprunts = this.emprunts;
    }
  }

}
