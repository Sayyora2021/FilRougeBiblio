import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ILecteur } from 'src/Interfaces/ILecteur';
import { Observable, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LecteurService {

   httpOptions = {
     headers: new HttpHeaders({
       'Content-Type': 'application/json',
     })
   };

  constructor(private http: HttpClient) { 
  }




  create(lecteur:ILecteur){
    this.http.post<ILecteur>('https://localhost:7120/api/Lecteurs/Create',lecteur).subscribe();
    
  }




  update(lecteur:ILecteur,id:number){
    
  }




  delete(id:number){
    
  }




  detail(id:number) : Observable<ILecteur>{
    return this.http.get<ILecteur>('https://localhost:7120/api/Lecteurs/Detail/' + id);

  }




  listAll() : Observable<ILecteur[]>{

    return this.http.get<ILecteur[]>('https://localhost:7120/api/Lecteurs').pipe(
    map((data: ILecteur[]) => {
      return data;
    })
  );



    // this.http.get<ILecteur[]>('https://localhost:7120/api/Lecteurs').subscribe((data: ILecteur[]) => {
    // return data;
    // });
  }

}
