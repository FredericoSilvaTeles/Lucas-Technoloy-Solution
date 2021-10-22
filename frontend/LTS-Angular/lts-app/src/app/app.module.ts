import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouteReuseStrategy } from '@angular/router';

import { IonicModule, IonicRouteStrategy } from '@ionic/angular';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { InvoiceControlComponent } from './finance/invoice-control/invoice-control.component';
import { PaymentSchedulingComponent} from './finance/payment-scheduling/payment-scheduling.component'

@NgModule({
  declarations: [AppComponent],
  entryComponents: [],
  imports: [BrowserModule, IonicModule.forRoot(), AppRoutingModule],
  providers: [{ provide: RouteReuseStrategy, useClass: IonicRouteStrategy }],
  bootstrap: [
      AppComponent,
      InvoiceControlComponent,
      PaymentSchedulingComponent

  ],
})
export class AppModule {}
