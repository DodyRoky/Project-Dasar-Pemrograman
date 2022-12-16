<template>
    <v-footer id="footer" app padless absolute dark>
     <v-card
       class="flex"
       flat
       title
       >
         <v-card-title class="teal">
            <strong class="subheading">Get connected with us on social networks!</strong>

            <v-spacer></v-spacer>

            <v-btn
            v-for="icon in icons"
            :key="icon"
            class="mx-5"
            dark
            icon
        >
           <v-icon size="24px">{{ icon }}</v-icon>
        </v-btn>
         </v-card-title>

         <v-card-actions id="copyright">
            ©2018 - <strong>Universitas Riau</strong>
         </v-card-actions>
      </v-card>
    </v-footer>
</template>

<script>
  export default {
    data: () => ({
        icons: [
            'mdi-facebook',
            'mdi-twitter',
            'mdi-google-plus',
            'mdi-linkedin',
            'mdi-instagram',
        ]
    })
  }
</script>

<style>
#footer .teal{
  background-color: darkgreen;
}
#copyright  {
  justify-content: center;
}
</style>